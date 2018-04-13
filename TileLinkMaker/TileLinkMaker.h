// TileLinkMaker.h : main header file for the TILELINKMAKER application
//

#if !defined(AFX_TILELINKMAKER_H__47D1E4CF_1B48_453E_A836_1EAC11ADEC1A__INCLUDED_)
#define AFX_TILELINKMAKER_H__47D1E4CF_1B48_453E_A836_1EAC11ADEC1A__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CTileLinkMakerApp:
// See TileLinkMaker.cpp for the implementation of this class
//

class CTileLinkMakerApp : public CWinApp
{
public:
	CTileLinkMakerApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTileLinkMakerApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CTileLinkMakerApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TILELINKMAKER_H__47D1E4CF_1B48_453E_A836_1EAC11ADEC1A__INCLUDED_)
