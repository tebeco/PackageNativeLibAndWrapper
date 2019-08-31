// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the THIRDPARTNATIVE_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// THIRDPARTNATIVE_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef THIRDPARTNATIVE_EXPORTS
#define THIRDPARTNATIVE_API __declspec(dllexport)
#else
#define THIRDPARTNATIVE_API __declspec(dllimport)
#endif

// This class is exported from the dll
class THIRDPARTNATIVE_API CThirdPartNative {
public:
	CThirdPartNative(void);
};

extern "C" THIRDPARTNATIVE_API int nPointerSize;

extern "C" THIRDPARTNATIVE_API int getPointerSize(void);
