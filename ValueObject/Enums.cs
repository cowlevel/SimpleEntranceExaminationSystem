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
        [Description("Multiple Choice")]
        MultipleChoice = 0,

        [Description("True or False")]
        TrueOrFalse = 1,

        [Description("Fill in the Blank")]
        FillInTheBlank = 2
    }
    #endregion
}