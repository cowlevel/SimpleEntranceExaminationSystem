using System.ComponentModel;

namespace ValueObject
{
    #region ENUM
    public enum Operation
    {
        Adding = 0,
        Editing = 1,
        Clear = 2
    }

    public enum ExamType
    {
        MultipleChoice = 0,
        TrueOrFalse = 1,
        TypeTheAnswer = 2
    }
    #endregion
}