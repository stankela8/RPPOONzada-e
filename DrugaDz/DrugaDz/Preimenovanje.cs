using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugaDz
{
    public class Preimenovanje
    {
        //2. zadatak
        public class Product
        {
            public string Name { get; private set; } 
            public string Price { get; private set; } 
            public bool InStock { get; set; } 

            public Product(string name, string price)
            {
                Name= name;
                Price = price;
                InStock = false;
            }
        }
        public class ProductHandler
        {
            List<Product> products;

            public ProductHandler(List<Product> inventory) 
            {
                products = inventory;
            }
            public void RestockProduct(Product product) 
            {
                foreach(Product item in  products) 
                {
                    if(product==item)
                    {
                        item.InStock = true;
                    }
                }
            }
            public void RemoveSoldOutProducts()
            {
                products.RemoveAll(product => product.InStock == false);
            }
        }
        //4. zadatak
        public class Note
        {
            public string Title { get; set; }
            public string Text { get; set; }
            public DateTime CreatedAt { get; private set; }

            public Note(string title, string text)
            {
                Title = title;
                Text = text;
                CreatedAt = DateTime.Now;
            }
        }
        public class NoteCollection
        {
            public string Author { get; private set; }
            public List<Note> notes;

            public NoteCollection(string author)
            {
                Author = author;
                notes = new List<Note>();
            }

            public void AddNote(Note note)
            {
                notes.Add(note);
            }
        }
        //5. zadatak
        public class Location
        {
            public DateTime CreatedAt { get; private set; } 
            public double Latitude { get; private set; } 
            public double Longitude { get; private set; } 

            public Location(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
                CreatedAt = DateTime.Now;
            }
        }
        public class PathManaging
        {
            private List<Location> pathLocations;

            public PathManaging()
            {
                pathLocations = new List<Location>();
            }

            public void AddLocation(Location location)
            {
                pathLocations.Add(location);
            }

            public void RemoveLocation(Location location)
            {
                pathLocations.Remove(location);
            }
        }
    }
}
