namespace ExtensionMethods
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int lenght)
        {
            var result = new StringBuilder();

            if (index < 0 || index >= builder.Length
                || lenght >= builder.Length)
            {
                throw new IndexOutOfRangeException("There isn't such index");
            }

            for (int i = index; i < lenght + index; i++)
            {
                result.Append(builder[i]);
            }

            return result;
        }
    }
}
