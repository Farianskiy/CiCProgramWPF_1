
namespace WpfLibrary1
{
    public class ZadahaOne
    {
        public string[] GetGraphicRepresentation(int digit)
        {
            switch (digit)
            {
                case 0:
                    return new string[]
                    {
                        "##",
                        "##",
                        "##",
                        "##"
                    };
                case 1:
                    return new string[]
                    {
                        ".#",
                        "##",
                        ".#",
                        ".#"
                    };
                case 2:
                    return new string[]
                    {
                        "##",
                        ".#",
                        "##",
                        "##"
                    };
                case 3:
                    return new string[]
                    {
                        "##",
                        ".#",
                        ".#",
                        "##"
                    };
                case 4:
                    return new string[]
                    {
                        "##",
                        "##",
                        ".#",
                        ".#"
                    };
                case 5:
                    return new string[]
                    {
                        "##",
                        "#.",
                        ".#",
                        "##"
                    };
                case 6:
                    return new string[]
                    {
                        ".#",
                        "#.",
                        "##",
                        "##"
                    };
                case 7:
                    return new string[]
                    {
                        "##",
                        ".#",
                        "#.",
                        "#."
                    };
                case 8:
                    return new string[]
                    {
                        "##",
                        "..",
                        "##",
                        "##"
                    };
                case 9:
                    return new string[]
                    {
                        "##",
                        "##",
                        ".#",
                        "#."
                    };
                default:
                    throw new ArgumentException("Число должно быть в диапазоне от 0 до 9.");
            }

        }
    }
}
