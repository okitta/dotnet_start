using Xunit;
using System;
using System.IO;

public class ProgramTest
{
    [Fact]
    public void TestAverage()
    {
        // Given
        string userInput = "John\n3\nMath\n95\nScience\n85\nHistory\n78";
        string expectedOutput = "Student Name: John\nYour Math result is 95\nYour Science result is 85\nYour History result is 78\nYour total result is 258 and total average is 86";

        // When
        using (var sw = new StringWriter())
        {
            using (var sr = new StringReader(userInput))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                // Act
                Program.Main(null);

                // Assert
                string actualOutput = sw.ToString().Trim();
                Console.WriteLine(actualOutput);
                Assert.Equal(expectedOutput, actualOutput);
            }
        }
        // Then
    }
}
