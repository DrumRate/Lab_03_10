using System;

namespace Lab03_10 
{
    [Serializable]
    public class Test : TestParent
    {
        public int Sup = 3;
        public void Load(int count)
        {
            throw new NotImplementedException();
        }
    }
}