// TileLinkMakerDlg.h : header file
//

#if !defined(AFX_TILELINKMAKERDLG_H__F0EB97F7_6A33_4FD7_8AB5_B00ACEA99B2B__INCLUDED_)
#define AFX_TILELINKMAKERDLG_H__F0EB97F7_6A33_4FD7_8AB5_B00ACEA99B2B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CTileLinkMakerDlg dialog

class CTileLinkMakerDlg : public CDialog
{
// Construction
public:
	CTileLinkMakerDlg(CWnd* pParent = NULL);	// standard constructor

	//根据文本框的内容获取取值范围
	void GetValueBoundsInt(CEdit *valueEdit,int &minValue,int &maxValue);
	void GetValueBoundsFloat(CEdit *valueEdit,double &minValue,double &maxValue);
// Dialog Data
	//{{AFX_DATA(CTileLinkMakerDlg)
	enum { IDD = IDD_TILELINKMAKER_DIALOG };
	CEdit	m_TileCount;
	CEdit	m_projectY;
	CEdit	m_projectX;
	CEdit	m_longitude;
	CEdit	m_latitude;
	CEdit	m_dz;
	CEdit	m_x;
	CEdit	m_y;
	CEdit	m_z0;
	CEdit	m_z;
	CEdit	m_y0;
	CEdit	m_x0;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTileLinkMakerDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CTileLinkMakerDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	virtual void OnOK();
	afx_msg void OnButtonTotilebylonglatitude();
	afx_msg void OnButtonTotilebyproject();
	afx_msg void OnButtonTobound();
	afx_msg void OnButtonNewtile();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TILELINKMAKERDLG_H__F0EB97F7_6A33_4FD7_8AB5_B00ACEA99B2B__INCLUDED_)
