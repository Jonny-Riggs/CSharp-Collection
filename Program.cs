using System;
using System.Collections.Generic;

namespace Sample {
    class Program {
        static void Main () {
            /*
                In JavaScript, the equivalent of the statement below would be:

                const product = {
                    name: "Yo-yo",
                    quantity: 1,
                    price: 9.04
                }
            */

            (string name, int quantity, double price) product = ("Yo-Yo", 1, 9.04);

            //Now I can use the named properties on the objectc
            Console.WriteLine ($"{product.name} {product.quantity} {product.price}");

            product.quantity = 2;
            Console.WriteLine ($"{product.quantity}");
        }
    }
}