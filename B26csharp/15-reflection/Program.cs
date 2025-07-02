#region early binding

//customer c = new customer();
//c.PrintA();

#endregion early binding

#region late binding

//using System.Reflection;

////find assembly

//Assembly assembly = Assembly.GetExecutingAssembly();

//Type customertype = assembly.GetType("customer");

//object instance = Activator.CreateInstance(customertype);

//MethodInfo printA = customertype.GetMethod("printA");
//printA.Invoke(instance, null);

//MethodInfo printB = customertype.GetMethod("printB");
//printB.Invoke(instance, null);

//MethodInfo printC = customertype.GetMethod("printC");
//printC.Invoke(instance, new object[] { "ankita" });

//MethodInfo printD = customertype.GetMethod("printD");
//object result = printD.Invoke(instance, null);
//Console.WriteLine(result);

//MethodInfo printE = customertype.GetMethod("printE", BindingFlags.Instance | BindingFlags.NonPublic);
//printE.Invoke(instance, null);


#endregion late binding

#region more about reflection

using System.Reflection;

Assembly assembly = Assembly.GetExecutingAssembly();
Type customertype = assembly.GetType("customer");

MethodInfo[] methods = customertype.GetMethods();
foreach (MethodInfo method in methods)
{
    Console.WriteLine(method.Name);
}

FieldInfo[] fields = customertype.GetFields();
foreach(FieldInfo field in fields)
{
    Console.WriteLine($"{field.FieldType} {field.Name}");
}

PropertyInfo[] properties = customertype.GetProperties();
foreach(PropertyInfo property in properties)
{
    Console.WriteLine($"{property.Name} {property.PropertyType}");
}


#endregion more about reflection

Console.Read();