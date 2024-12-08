﻿namespace tcs.Naming;

public sealed class KebabCase : NamingCaseBase
{
    public override string? SpecialCharacters => "-";

    public override string ConvertTo(string value, NamingOptions options)
    {
        var words = GetWords(value, options, CharacterCasing.Lower);
        return string.Join("-", words);
    }
}
