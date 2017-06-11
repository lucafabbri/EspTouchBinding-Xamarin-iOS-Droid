using System;
using System.Collections.Generic;

namespace EspTouchSmartConfigXamarin
{
    public interface ISmartConfigTask
	{
		ISmartConfigResult executeForResult();
		List<ISmartConfigResult> executeForResults(int expectTaskResultCount);
    }
}
