namespace N17.AbstractClass
{
    public class NormalType
    {
        public virtual void DoSomething()
        {

        }
    }

    public abstract class AbstractType : NormalType
    {
        // ham override ham abstract method bo'lishi mumkin
        // abstract tip ichida override qilish mumkin
        public override void DoSomething()
        {
            base.DoSomething();
        }
    }
}
