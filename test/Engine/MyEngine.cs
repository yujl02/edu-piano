using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace test.Engine
{
    public class MyEngine
    {
        position pos = new position();
        time time = new time();
        bar bar = new bar();
        line line = new line();
        song song = new song();

        public MyEngine()
        {
            main.btn_bar.Click += btn_Click;
            main.btn_line.Click += btn_Click;
            main.btn_position.Click += btn_Click;
            main.btn_song.Click += btn_Click;
            main.btn_time.Click += btn_Click;
        }

        void btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
           Button btn = sender as Button;
           
        }

        private MainWindow main;
        public void init(MainWindow main)
        {
            this.main = main;
        }
    }
      
}
