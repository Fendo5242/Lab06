using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<StudentGroup> studentGroups = new List<StudentGroup>
        {
            new StudentGroup("Sección A", new List<Student>
            {
                new Student { Name = "Pablo", LastName = "Huamanculi" , Age = 18 },
                new Student { Name = "Lizeth", LastName = "Castellanos", Age = 19 },
                new Student { Name = "Saida", LastName = "Rios", Age = 20 },
                new Student { Name = "Ana", LastName = "Martínez", Age = 22 }
            }),
            new StudentGroup("Sección B", new List<Student>
            {
                new Student { Name = "Jose", LastName = "Perez" , Age = 22 },
                new Student { Name = "Miguel", LastName = "Torres", Age = 23 },
                new Student { Name = "Juan", LastName = "Lopez", Age = 18  },
                new Student { Name = "Laura", LastName = "Rodríguez", Age = 17 },
                new Student { Name = "Javier", LastName = "López", Age = 19 },
            }),
            new StudentGroup("Sección C", new List<Student>
            {
                new Student { Name = "Fernanda", LastName = "Silva", Age = 20 },
                new Student { Name = "Pedro", LastName = "Ortega", Age = 18 },
                new Student { Name = "Carolina", LastName = "Garcia", Age = 20 },
                new Student { Name = "Laura", LastName = "Hernandez", Age = 20 },
                new Student { Name = "Ricardo", LastName = "Alvarez", Age = 19 }
            }),
            new StudentGroup("Seccion D", new List<Student>
            {
                new Student { Name = "Lucía", LastName = "Sánchez", Age = 18 },
                new Student { Name = "Daniel", LastName = "Torres", Age = 19 },
                new Student { Name = "Laura", LastName = "Vargas", Age = 20 },
                new Student { Name = "Andrea", LastName = "López", Age = 22 },
                new Student { Name = "Javier", LastName = "Mendoza", Age = 21 }
            })
        };

            listView.ItemsSource = studentGroups;
        }

    }
}