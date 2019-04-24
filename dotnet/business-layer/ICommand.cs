namespace com.opusmagus
{
    public interface ICommand<I, O>
    {
        O Execute(I input);
    }
}