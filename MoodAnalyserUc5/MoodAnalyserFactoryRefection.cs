using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUc5
{
    public class MoodAnalyserFactoryRefection
    {
        /// <summary>
        /// Reflection UC5 using parameter constructor
        /// Creates the mood analyser parameter object.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructor">The constructor.</param>
        /// <param name="message">The message.</param>

        public object CreateMoodAnalyserParameterObject(string className, string constructor, string message)
        {
                Type tyep = typeof(MoodAnalyser);
                if (tyep.Name.Equals(className) || tyep.FullName.Equals(className))
                {
                    if (tyep.Name.Equals(constructor))
                    {
                        ConstructorInfo constructorInfo = tyep.GetConstructor(new[] { typeof(string) });
                        var obj = constructorInfo.Invoke(new object[] { message });
                        return obj;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");
                    }
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.Class_Not_Found, "class not found");

                }


            }

           
    }
}
