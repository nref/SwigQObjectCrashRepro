using TestCpp;

using (var derived = new Derived())
{
  Console.WriteLine(derived.GetSharedPtr().objectName());
};
