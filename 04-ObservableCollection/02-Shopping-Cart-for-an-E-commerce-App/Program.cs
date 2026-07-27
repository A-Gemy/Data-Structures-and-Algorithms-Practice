using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Shopping_Cart_for_an_E_commerce_App
{
    class CartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public CartItem(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name} - Price: {Price:C}, Quantity: {Quantity}";
        }
    }

    class Program
    {
        private static void Cart_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Item added: {e.NewItems[0]}");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Item removed: {e.OldItems[0]}");
                    break;

                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine($"Item replaced: {e.OldItems[0]} with {e.NewItems[0]}");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Cart cleared.");
                    break;
            }
        }

        private static void DisplayCart(ObservableCollection<CartItem> cart)
        {
            if (cart == null || cart.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
                return;
            }

            foreach (CartItem item in cart)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            ObservableCollection<CartItem> cart = new ObservableCollection<CartItem>();

            cart.CollectionChanged += Cart_CollectionChanged;

            cart.Add(new CartItem("Laptop", 25000, 1));
            cart.Add(new CartItem("Mouse", 500, 2));

            cart.RemoveAt(1);

            cart[0] = new CartItem("Keyboard", 1200, 1);

            Console.WriteLine();
            Console.WriteLine("Current Cart:");
            DisplayCart(cart);

            Console.WriteLine();
            cart.Clear();


            Console.ReadKey();
        }
    }
}
