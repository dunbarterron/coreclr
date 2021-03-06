using System;
/// <summary>
///Enum
/// </summary>

public class AttributeTargetsEnum
{
    public static int Main()
    {
        AttributeTargetsEnum AttributeTargetsEnum = new AttributeTargetsEnum();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsEnum");
        if (AttributeTargetsEnum.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Enum value is 0x0010. ");
        try
        {
            int expectValue = 0x0010;
            if ((int)AttributeTargets.Enum != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Enum should return 0x0010.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

