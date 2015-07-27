using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using test.Engine;
namespace test
{
	
    public partial class MainWindow : Window
    {
        position pos = new position();
		time time = new time();
		bar bar = new bar();
		line line = new line();
		song song = new song();
        public MainWindow()
        {
            InitializeComponent();
            MyEngine myEngine = new MyEngine();
            myEngine.init(this);
        }

        //private void btn_position_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    // TODO: 여기에 구현된 이벤트 처리기를 추가하십시오.
        //    frame.Children.Clear();
        //    frame.Children.Add(pos);

        //}

        //private void btn_time_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    // TODO: 여기에 구현된 이벤트 처리기를 추가하십시오.
        //    frame.Children.Clear();
        //    frame.Children.Add(time);
        //}

        //private void btn_bar_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    // TODO: 여기에 구현된 이벤트 처리기를 추가하십시오.
        //    frame.Children.Clear();
        //    frame.Children.Add(bar);
        //}

        //private void btn_line_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    // TODO: 여기에 구현된 이벤트 처리기를 추가하십시오.
        //    frame.Children.Clear();
        //    frame.Children.Add(line);
        //}

        //private void btn_song_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    // TODO: 여기에 구현된 이벤트 처리기를 추가하십시오.
        //    frame.Children.Clear();
        //    frame.Children.Add(song);
        //}
    }
}
