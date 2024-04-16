namespace Balta.ContentContext 
{
    public abstract class Content //abstract, pois não faz sentido (regra de negócio) um Content ser estanciado. 
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
    }
}