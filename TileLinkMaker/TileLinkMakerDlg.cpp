// TileLinkMakerDlg.cpp : implementation file
//

#include "stdafx.h"
#include "TileLinkMaker.h"
#include "TileLinkMakerDlg.h"
#include <afx.h>
#include "math.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
		// No message handlers
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CTileLinkMakerDlg dialog

CTileLinkMakerDlg::CTileLinkMakerDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CTileLinkMakerDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CTileLinkMakerDlg)
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CTileLinkMakerDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CTileLinkMakerDlg)
	DDX_Control(pDX, IDC_EDIT_TileCount, m_TileCount);
	DDX_Control(pDX, IDC_EDIT_projectY, m_projectY);
	DDX_Control(pDX, IDC_EDIT_projectX, m_projectX);
	DDX_Control(pDX, IDC_EDIT_longitude, m_longitude);
	DDX_Control(pDX, IDC_EDIT_latitude, m_latitude);
	DDX_Control(pDX, IDC_EDIT_dz, m_dz);
	DDX_Control(pDX, IDC_EDIT_x, m_x);
	DDX_Control(pDX, IDC_EDIT_y, m_y);
	DDX_Control(pDX, IDC_EDIT_z0, m_z0);
	DDX_Control(pDX, IDC_EDIT_z, m_z);
	DDX_Control(pDX, IDC_EDIT_y0, m_y0);
	DDX_Control(pDX, IDC_EDIT_x0, m_x0);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CTileLinkMakerDlg, CDialog)
	//{{AFX_MSG_MAP(CTileLinkMakerDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON_TOTILEBYLONGLATITUDE, OnButtonTotilebylonglatitude)
	ON_BN_CLICKED(IDC_BUTTON_TOTILEBYPROJECT, OnButtonTotilebyproject)
	ON_BN_CLICKED(IDC_BUTTON_TOBOUND, OnButtonTobound)
	ON_BN_CLICKED(IDC_BUTTON_NEWTILE, OnButtonNewtile)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CTileLinkMakerDlg message handlers

BOOL CTileLinkMakerDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CTileLinkMakerDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CTileLinkMakerDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CTileLinkMakerDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}


//#########以下为业务代码


const double semiPerimeterOfEquator=20037508.3427892;//赤道周长的一半（米）
const double PI=3.1415926;//圆周率

//根据文本框的内容获取取值范围
void CTileLinkMakerDlg::GetValueBoundsInt(CEdit *valueEdit,int &minValue,int &maxValue)
{
	CString strValue;
	valueEdit->GetWindowText(strValue);
	//AfxMessageBox(strValue);
	int index=strValue.Find('-');
	if (index==-1)
	{
		minValue=maxValue=atoi(strValue);
		return;
	}
	CString strMinValue=strValue.Left(index);
	CString strMaxValue=strValue.Right(strValue.GetLength()-index-1);
	//AfxMessageBox(strMinValue);
	//AfxMessageBox(strMaxValue);
	minValue=atoi(strMinValue);
	maxValue=atoi(strMaxValue);
}
void CTileLinkMakerDlg::GetValueBoundsFloat(CEdit *valueEdit,double &minValue,double &maxValue)
{
	CString strValue;
	valueEdit->GetWindowText(strValue);
	//AfxMessageBox(strValue);
	int index=strValue.Find('-');
	if (index==-1)
	{
		minValue=maxValue=atof(strValue);
		return;
	}
	CString strMinValue=strValue.Left(index);
	CString strMaxValue=strValue.Right(strValue.GetLength()-index-1);
	//AfxMessageBox(strMinValue);
	//AfxMessageBox(strMaxValue);
	minValue=atof(strMinValue);
	maxValue=atof(strMaxValue);
}


void CTileLinkMakerDlg::OnOK() 
{	
	//生成瓦片下载链接数据
	CFile mFile("TileLinkers.txt",CFile::modeWrite|CFile::modeCreate);

	int x1,x2;//新瓦片横向索引值范围
	GetValueBoundsInt(&m_x,x1,x2);
	int dx=x2-x1+1;
	
	int y1,y2;//新瓦片纵向索引值范围
	GetValueBoundsInt(&m_y,y1,y2);
	int dy=y2-y1+1;
	
	CString strZ;
	m_z.GetWindowText(strZ);
	int z=atoi(strZ);//新缩放层级		
	
	CString str="";

	for (int i=0;i<dx;i++)
	{
		for (int j=0;j<dy;j++)
		{
			str.Format("http://mt2.google.cn/vt/lyrs=m@167000000&hl=zh-CN&gl=cn&x=%d&y=%d&z=%d&s=Galil\r\n",x1+i,y1+j,z); 
			mFile.Write(str,str.GetLength());
		}
	}

	mFile.Flush();
    mFile.Close();

	AfxMessageBox("完成！");
}

//根据经纬度计算瓦片值
void CTileLinkMakerDlg::OnButtonTotilebylonglatitude() 
{
	CString strLongitude;//经度
	m_longitude.GetWindowText(strLongitude);
	double longitude=atof(strLongitude);

	CString strLatitude;
	m_latitude.GetWindowText(strLatitude);
	double latitude=atof(strLatitude);

	double projectX=semiPerimeterOfEquator*longitude/180;
	double projectY=semiPerimeterOfEquator*sin(latitude)/PI;
	
	CString strProjecX;
	strProjecX.Format("%f",projectX);
	CString strProjecY;
	strProjecY.Format("%f",projectY);

	m_projectX.SetWindowText(strProjecX);
	m_projectY.SetWindowText(strProjecY);

	CString strZ0;
	m_z0.GetWindowText(strZ0);
	int z0=atoi(strZ0);//初始缩放层级，0级时全世界地图为一块256像素的图片

	double xCount,yCount;//当前缩放层级对应的横向和纵向瓦片块数
	xCount=yCount=pow(2,z0);
	double resolution=semiPerimeterOfEquator*2/xCount/256;//单位像素代表的长度

	double x0=(projectX+semiPerimeterOfEquator)/resolution/256;
	double y0=(semiPerimeterOfEquator-projectY)/resolution/256;

	CString strX0;//初始瓦片横向索引值范围
	strX0.Format("%f",x0);
	m_x0.SetWindowText(strX0);

	CString strY0;//初始瓦片纵向索引值范围
	strY0.Format("%f",y0);
	m_y0.SetWindowText(strY0);

}

//根据投影计算瓦片值
void CTileLinkMakerDlg::OnButtonTotilebyproject() 
{
	
	
}

//计算范围值
void CTileLinkMakerDlg::OnButtonTobound() 
{
	
	
}

//计算新瓦片值
void CTileLinkMakerDlg::OnButtonNewtile() 
{	
	int x01,x02;//初始瓦片横向索引值范围
	GetValueBoundsInt(&m_x0,x01,x02);
	int dx=x02-x01+1;
	
	int y01,y02;//初始瓦片纵向索引值范围
	GetValueBoundsInt(&m_y0,y01,y02);
	int dy=y02-y01+1;
	
	CString strZ0;
	m_z0.GetWindowText(strZ0);
	int z0=atoi(strZ0);//初始缩放层级，0级时全世界地图为一块256像素的图片

	CString strDz;
	m_dz.GetWindowText(strDz);
	int dz=atoi(strDz);//相对初始缩放层级增加的层级数

	CString strZ;//新缩放层级
	strZ.Format("%d",z0+dz);
	m_z.SetWindowText(strZ);

	CString strTileCount;//新瓦片数量
	strTileCount.Format("%d",dx*dy*(int)pow(4,dz));
	m_TileCount.SetWindowText(strTileCount);

	CString strX;//新瓦片横向索引值范围
	strX.Format("%d-%d",x01*(int)pow(2,dz),(x02+1)*(int)pow(2,dz)-1);
	m_x.SetWindowText(strX);

	CString strY;//新瓦片纵向索引值范围
	strY.Format("%d-%d",y01*(int)pow(2,dz),(y02+1)*(int)pow(2,dz)-1);
	m_y.SetWindowText(strY);
}


