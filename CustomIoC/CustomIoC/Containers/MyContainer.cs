namespace CustomIoC.Containers;

public class MyContainer
{
    private readonly Dictionary<Type, Func<object>> _registrations = new Dictionary<Type, Func<object>>();

    public void Register<TService, TImplementation>() where TImplementation : TService
    {
        _registrations[typeof(TService)] = () => Activator.CreateInstance(typeof(TImplementation));
    }
    
    public TService Resolve<TService>()
    {
        if (_registrations.TryGetValue(typeof(TService), out var factory))
        {
            return (TService)factory.Invoke();
        }

        throw new InvalidOperationException($"No registration for type {typeof(TService)} found");
    }
}