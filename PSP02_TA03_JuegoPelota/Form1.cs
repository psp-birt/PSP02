using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSP02_JuegoPelota
{
    public partial class JuegoPelota : Form
    {
        public JuegoPelota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            t1.Start();
            t2.Start();
        }

        //Se crean dos objetos
        object onina1 = new object();
        object onina2 = new object();

        private void PasePelota()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (onina2)
                    Monitor.Pulse(onina2);
                    
                lock (onina1)
                {
                    try
                    {
                        Thread.Sleep(1000);
                        Monitor.Wait(onina1);                      
                        MoverPelotaPie(-180);
                        MoverPelotaMano(180);
                    }
                    catch (ThreadAbortException e)
                    {
                        Debug.WriteLine(e.ToString());
                    }
                }
            }
        }

       

        private void DevolverPelota()
        {
            for (int i = 0; i < 1000; i++)
            {
                //turno de la niña1
                lock (onina1)
                    Monitor.Pulse(onina1);
                    
                lock (onina2)
                {
                    try 
                    {
                        Thread.Sleep(1000);
                        Monitor.Wait(onina2);                    
                        MoverPelotaPie(180);
                        MoverPelotaMano(-180);
                    }
                    catch (ThreadAbortException e)
                    {
                        Debug.WriteLine(e.ToString());
                    }
                    
                }
            }
        }
        /*Para mostrar el movimiento en la imagen, éste debe 'avisar' de algún modo mediante un evento o un delegado(esto se hace mediante Invoke).
         mediante el value le pasamos el parámetro de cuánto se tiene que mover*/

        public void MoverPelotaPie(int value)
        {
            try
            {
                if (this == null) return;
                Invoke(new Action(() => picturepelotapie.Location = new Point(picturepelotapie.Location.X + value, picturepelotapie.Location.Y)));
            }catch(Exception e) 
            {
                Debug.WriteLine(e.ToString());
            }
        }
        public void MoverPelotaMano(int value)
        {
            try
            {
                if (this == null) return;
                Invoke(new Action(() => picturepelomano.Location = new Point(picturepelomano.Location.X + value, picturepelomano.Location.Y)));
            }catch(Exception e) 
            {
                Debug.WriteLine(e.ToString());

            }
        }

        private void JuegoPelota_Load(object sender, EventArgs e)
        {
            if (t1.IsAlive) { Debug.WriteLine(e.ToString()); }
            if (t1.IsAlive) { Debug.WriteLine(e.ToString()); }
        }
    }

    
}
