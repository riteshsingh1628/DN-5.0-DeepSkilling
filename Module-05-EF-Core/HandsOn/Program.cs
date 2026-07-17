using System;
using System.Linq;
using RetailInventorySystem.Data;
using RetailInventorySystem.Models;
using var context = new AppDbContext();
// Create Database
context.Database.EnsureCreated();
Console.WriteLine("=== Retail Inventory System ===");
// CREATE
var product = new Product
{
    ProductName = "Laptop",
    Price = 55000,
    Quantity = 5
};
context.Products.Add(product);
context.SaveChanges();
Console.WriteLine("Product Added Successfully!");
// READ
Console.WriteLine("\nProduct List:");
foreach (var p in context.Products)
{
    Console.WriteLine($"{p.ProductId} - {p.ProductName} - {p.Price} - {p.Quantity}");
}
// UPDATE
var updateProduct = context.Products.FirstOrDefault();
if (updateProduct != null)
{
    updateProduct.Price = 60000;
    context.SaveChanges();

    Console.WriteLine("\nProduct Updated Successfully!");
}
// DELETE
var deleteProduct = context.Products.FirstOrDefault();

if (deleteProduct != null)
{
    context.Products.Remove(deleteProduct);
    context.SaveChanges();

    Console.WriteLine("Product Deleted Successfully!");
}
// FINAL LIST
Console.WriteLine("\nFinal Product List:");
foreach (var p in context.Products)
{
    Console.WriteLine($"{p.ProductId} - {p.ProductName} - {p.Price} - {p.Quantity}");
}

Console.WriteLine("\nCRUD Operations Completed Successfully!");
