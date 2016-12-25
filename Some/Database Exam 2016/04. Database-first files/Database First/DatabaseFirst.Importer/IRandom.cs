using System;

namespace DatabaseFirst.Importer
{
    public interface IRandom
    {
        int RandomNumber(int min, int max);

        string RandomString(int minLength, int maxLength);

        DateTime RandomDateTime(DateTime? after = null, DateTime? before = null);
    }
}
