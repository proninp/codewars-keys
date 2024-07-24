using Kata._6_kyu.Count_characters_in_your_string;

namespace KataTests._6_kyu.Count_characters_in_your_string
{
    public class CountCharactersInYourStringTests
    {
        [Fact]
        public static void SampleTest_a()
        {
            // Arrange
            Dictionary<char, int> d = new Dictionary<char, int> { { 'a', 1 } };
            string s = "a";

            // Act

            // Assert
            Tester(d, CountCharactersInYourString.Count(s), s);
        }
        [Fact]
        public static void SampleTest_aba()
        {
            // Arrange
            Dictionary<char, int> d = new Dictionary<char, int> { { 'a', 2 }, { 'b', 1 } };
            string s = "aba";

            // Act

            // Assert
            Tester(d, CountCharactersInYourString.Count(s), s);
        }

        private static void Tester(Dictionary<char, int> expected, Dictionary<char, int> actual, string input)
        {
            foreach (KeyValuePair<char, int> entry in expected)
            {
                char key = entry.Key;
                if (actual.ContainsKey(key))
                {
                    int val = entry.Value;
                    int num = actual[key];
                    if (num != val)
                    {
                        Assert.True(val == num,
                            $"For input string: \"{input}\"\n \n< Incorrect Value for Key '{key}' >");
                    }
                }
                else
                {
                    Assert.True(false,
                        $"For input string: \"{input}\"\n \n< The submitted Dictionary should contain an entry for key '{entry.Key}' >");
                }
            }
            foreach (KeyValuePair<char, int> entry in actual)
            {
                if (!expected.ContainsKey(entry.Key))
                {
                    Assert.False(true,
                        $"For input string: \"{input}\"\n \n< The submitted Dictionary should NOT contain an entry for key '{entry.Key}' >");
                }
            }
            Assert.True(true);
        }
    }
}
