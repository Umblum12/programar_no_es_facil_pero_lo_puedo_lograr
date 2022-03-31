string ejemplo = "Programar no es fácil, pero lo puedo lograr";
string ejemplomod = ejemplo.Insert(43, ", atentamente Abelardo");
Console.WriteLine("{0}", ejemplo);
Console.WriteLine("{0}", ejemplomod.Replace(", pero lo puedo lograr", " pero lo voy a lograr"));
Console.ReadKey(true);