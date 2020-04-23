using UnityEngine;

public class A
{
    public void OnDoWork()
    {
        if (DoWork != null)
            DoWork(this, EventArgs.Empty);
    }

    public event EventHandler DoWork;
}