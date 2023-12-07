using Entidades.DataBase;
using Entidades.Files;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public delegate void DelegadoNuevoPedido<T>(T menu);

    public class Mozo<T> where T : IComestible, new()
    {
        private CancellationTokenSource cancellation;
        private T menu;
        private Task tarea;

        public bool EmpezarATrabajar
        {
            get
            {
                return this.tarea is not null && (this.tarea.Status == TaskStatus.Running ||
                    this.tarea.Status == TaskStatus.WaitingToRun ||
                    this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.EmpezarATrabajar)
                {
                    this.cancellation = new CancellationTokenSource();
                    this.TomarPedidos();
                }
                else
                {
                    this.cancellation.Cancel();
                }
            }
        }

        /// <summary>
        /// Verificara si el evento OnPedido posee suscriptores, si es asi instancia un menú e inicia la preparación
        /// </summary>
        private void NotificarNuevoPedido()
        {
            if (this.OnPedido is not null)
            {
                this.menu = new T();
                this.menu.IniciarPreparacion();
                this.OnPedido.Invoke(this.menu);
            }
        }

        /// <summary>
        /// Ejecuta en un hilo secundario la accion de notificar un ingreso de otra comida luego duerme el hilo por 5segundos
        /// </summary>
        private void TomarPedidos()
        {
            this.tarea = Task.Run(() =>
            {
                while (!this.cancellation.IsCancellationRequested)
                {
                    this.NotificarNuevoPedido();
                    Thread.Sleep(5000);
                }
            }, this.cancellation.Token);
        }

        //Evento
        public event DelegadoNuevoPedido<T> OnPedido;
    }
}
