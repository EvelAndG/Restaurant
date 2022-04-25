namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem myMenuItem = new MenuItem();
            myMenuItem.Name = "Fried Chicken";
            myMenuItem.Price = 15;
            myMenuItem.Description = "Tasty";
            myMenuItem.Category = "Bad for you";

         

            Console.WriteLine("{0} {1} {2} {3}",
                myMenuItem.Name,
                myMenuItem.Price,
                myMenuItem.Description,
                myMenuItem.Category);
        }

      

    }

    class Menu
    {
        public static List<MenuItem> Items = new List<MenuItem>();

        public static void AddItem()
        {
            //Take user input and add MenuItem to list, Items
        }
        public static void RemoveItem()
        {
            
        }
        public static void PrintMenu()
        {
            foreach (MenuItem item in Items)
            {
                Console.WriteLine(item.Name);
            }
        }

    }

    class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }


        
    }


   }