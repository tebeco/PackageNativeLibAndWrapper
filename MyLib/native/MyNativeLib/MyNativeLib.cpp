// MyNativeLib.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "MyNativeLib.h"


MYNATIVELIB_API int nPointerSize = sizeof(char*);

MYNATIVELIB_API int getPointerSize(void)
{
	return nPointerSize;
}

// This is the constructor of a class that has been exported.
CMyNativeLib::CMyNativeLib()
{
	return;
}
