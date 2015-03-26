using System;

namespace SchoolSystem.Inetrface
{
    public interface IPerson
    {
        string Email { get; }
        string Name { get; }

        void Walk();

    }
}
