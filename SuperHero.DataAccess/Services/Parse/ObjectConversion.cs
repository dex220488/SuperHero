namespace SuperHero.DataAccess.Services.Parse
{
    public abstract class ObjectConversion
    {
        public abstract object Cast(string jsonData);
    }
}