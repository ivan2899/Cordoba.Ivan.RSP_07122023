using Entidades.DataBase;
using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;


namespace Entidades.Modelos
{
    public delegate void DelegadoDemoraAtencion(double demora);
    public delegate void DelegadoNuevoIngreso(IComestible menu);

    public class Cocinero<T> where T : IComestible, new()
    {
        private CancellationTokenSource cancellation;
        private int cantPedidosFinalizados;
        private double demoraPreparacionTotal;
        private T menu;
        private string nombre;
        private Task tarea;

        public Cocinero(string nombre)
        {
            this.nombre = nombre;
        }

        //No hacer nada
        public bool HabilitarCocina
        {
            get
            {
                return this.tarea is not null && (this.tarea.Status == TaskStatus.Running ||
                    this.tarea.Status == TaskStatus.WaitingToRun ||
                    this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.HabilitarCocina)
                {
                    this.cancellation = new CancellationTokenSource();
                    this.IniciarIngreso();
                }
                else
                {
                    this.cancellation.Cancel();
                }
            }
        }

        //no hacer nada
        public string Nombre { get => this.nombre; }
        public double TiempoMedioDePreparacion { get => this.cantPedidosFinalizados == 0 ? 0 : this.demoraPreparacionTotal / this.cantPedidosFinalizados; }
        public int CantPedidosFinalizados { get => this.cantPedidosFinalizados; }

        /// <summary>
        /// Si posee un suscriptor notificara los segundos transcurridos, incrementando de a 1 (en formato cronometro)
        /// </summary>
        private void EsperarProximoIngreso()
        {
            int tiempoEspera = 0;

            if(this.OnDemora is not null)
            {
               while(!this.cancellation.IsCancellationRequested && !this.menu.Estado)
                {
                    Thread.Sleep(1000); 
                    tiempoEspera++;
                    this.OnDemora.Invoke(tiempoEspera);
                }
                    this.demoraPreparacionTotal += tiempoEspera;                
            }
        }

        /// <summary>
        /// Ejecuta en un hilo secundario la accion de notificar un ingreso de otra hamburguesa, incrementa la cantidad de pedidos finalizados y guarda el ticket de la hamburguesa en la BD
        /// </summary>
        private void IniciarIngreso()
        {
                this.tarea = Task.Run(() =>
                {
                    while (!this.cancellation.IsCancellationRequested)
                    {
                            NotificarNuevoIngreso();
                            EsperarProximoIngreso();
                            this.cantPedidosFinalizados++;

                        try
                        {
                            DataBaseManager.GuardarTicket(Nombre, this.menu);

                        }
                        catch (Exception ex)
                        {
                            FileManager.Guardar(ex.Message, "logs.txt", true);
                        }
                    }
                }, this.cancellation.Token);            
        }
 
        /// <summary>
        /// Verificara si el evento OnIngreso posee suscriptores, si es asi instancia un menú e inicia la preparación
        /// </summary>
        private void NotificarNuevoIngreso()
        {
                if (this.OnIngreso is not null)
                {
                    this.menu = new T();
                    this.menu.IniciarPreparacion();
                    this.OnIngreso.Invoke(this.menu);
                }
        }

        //Eventos
        public event DelegadoDemoraAtencion OnDemora;
        public event DelegadoNuevoIngreso OnIngreso;
    }
}
