namespace AppiumTestProj.Helpers
{
    public class AppiumBy
    {
        public string FindBy { get; }
        public string Value { get; }

        private AppiumBy(string findBy, string value)
        {
            FindBy = findBy;
            Value = value;
        }

        public static AppiumBy Name(string nameToFind)
        {
            return new AppiumBy("Name", nameToFind);
        }

        public static AppiumBy ClassName(string classNameToFind)
        {
            return new AppiumBy("ClassName", classNameToFind);
        }

        public static AppiumBy XPath(string XPathToFind)
        {
            return new AppiumBy("XPath", XPathToFind);
        }
    }
}