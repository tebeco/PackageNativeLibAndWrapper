// ThirdPartNative.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "ThirdPartNative.h"


THIRDPARTNATIVE_API int nPointerSize = sizeof(char*);

THIRDPARTNATIVE_API int getPointerSize(void)
{
	return nPointerSize;
}

// This is the constructor of a class that has been exported.
CThirdPartNative::CThirdPartNative()
{
	return;
}
