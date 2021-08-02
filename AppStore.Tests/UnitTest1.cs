using AppStore.Domain.StoreContext.Entities;
using AppStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Name name = new("Thales", "Correa");
            Document document = new("12345678911");
            Email email = new("thaleshenrique.correa@gmail.com");
            Customer customer = new(name, document, email, "0000000000");
            Product mouse = new Product("Mouse", "Rato", "image.png", 59, 10);
            Product teclado = new Product("Teclado", "Apertar as teclinhas", "image.png", 159, 10);
            Product impressora = new Product("Impressora", "Impressora", "image.png", 359, 10);
            Product cadeira = new Product("Cadeira", "Cadeira", "image.png", 559, 10);

            Order order = new Order(customer);
            order.AddItem(new(mouse, 5));
            order.AddItem(new(teclado, 5));
            order.AddItem(new(impressora, 5));
            order.AddItem(new(cadeira, 5));

            order.Place();

            order.Pay();

            order.Ship();

            order.Cancel();
        }
    }
}
