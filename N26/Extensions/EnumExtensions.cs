namespace N26.Extensions;

public enum LanguageLevel
{
    Beginner,
    Elementary,
    PreIntermediate,
    Intermediate,
    UpperIntermediate,
    Advanced,
    Proficiency
}

public static class EnumExtensions
{
    // public static bool IsDefined(this string value)
    // {
    //     var exists = false;
    //
    //     // working solutions -
    //     // if (LanguageLevel.Beginner.ToString() == value)
    //     //     exists = true;
    //     // else if (LanguageLevel.Elementary.ToString() == value)
    //     //     exists = true;
    //     // else if (LanguageLevel.PreIntermediate.ToString() == value)
    //     //     exists = true;
    //     // else if (LanguageLevel.Intermediate.ToString() == value)
    //     //     exists = true;
    //     // else if (LanguageLevel.UpperIntermediate.ToString() == value)
    //     //     exists = true;
    //     // else if (LanguageLevel.Advanced.ToString() == value)
    //     //     exists = true;
    //     // else if (LanguageLevel.Proficiency.ToString() == value)
    //     //     exists = true;
    //
    //     // right solution
    //     for (var index = 0; index < (int)LanguageLevel.Proficiency; index++)
    //         if (((LanguageLevel)index).ToString() == value)
    //             exists = true;
    //
    //     return exists;
    // }

    public static bool IsDefined<TEnum>(this string value) where TEnum : struct, Enum =>
        !string.IsNullOrWhiteSpace(value) && Enum.IsDefined(typeof(TEnum), value);

    // Null coalescing
    public static TEnum ToEnum<TEnum>(this string value) where TEnum : struct, Enum =>
        value?.IsDefined<TEnum>() ?? false
            ? Enum.Parse<TEnum>(value)
            : throw new ArgumentException($"Value {value} is not defined in enum {typeof(TEnum).Name}");
}