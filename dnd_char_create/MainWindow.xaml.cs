﻿using dnd_char_create.dataContext.Rases;
using dnd_char_create.model;
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

namespace dnd_char_create
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            raseView.ItemsSource = new List<Rase>() { Human.human ,Elf.elf};
           
            Character cha = new Character();

            charStats.ItemsSource = new List<stats>() { cha.stats };
        }
    }
}