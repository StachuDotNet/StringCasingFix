
using StringCasingFix;

Console.WriteLine($"Expected: 'TEST'; Actual: '{NetFxUpperCaseInvariant.NetFxToUpperInvariant("test")}");
Console.WriteLine($"Expected: 'FIFL'; Actual: '{NetFxUpperCaseInvariant.NetFxToUpperInvariant("ﬁﬂ")}");
Console.WriteLine($"Expected: 'ԵՒ'; Actual: '{NetFxUpperCaseInvariant.NetFxToUpperInvariant("և")}");