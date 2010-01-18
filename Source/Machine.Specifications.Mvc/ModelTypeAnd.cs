namespace Machine.Specifications.Mvc
{
    public class ModelTypeAnd<T>
    {
        readonly T model;

        public ModelTypeAnd(T model)
        {
            this.model = model;
        }

        public T And()
        {
            return this.model;
        }
    }
}