﻿using Factory_Method;

Console.Title = "Factory Method Pattern";

var factories = new List<DiscountFactory> {
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BE")
};

foreach(var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPercentage} " + 
        $"coming from { discountService }");
}

Console.ReadKey();