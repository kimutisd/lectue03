namespace Lecture03
{
    public class SampleCollection<T>
    {       
        private T[] arrayOfProvidedType = new T[100];
                
        public T this[int i]
        {
            get { return arrayOfProvidedType[i]; }
            set { arrayOfProvidedType[i] = value; }
        }
    }
}
