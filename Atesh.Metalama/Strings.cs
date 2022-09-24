namespace Atesh.Metalama;

public static class Strings
{
    public static string ValueCantBeLessThan(string Min) => $"Value can't be less than {Min}.";
    public static string ValueCantBeGreaterThan(string Max) => $"Value can't be greater than {Max}.";
    public static string ValueMustBeGreaterThan(string Min) => $"Value must be greater than {Min}.";
    public static string ValueMustBeLessThan(string Max) => $"Value must be less than {Max}.";
    public static string ValueMustBeBetween(string Min, string Max) => $"Value must be between {Min} and {Max}.";
}