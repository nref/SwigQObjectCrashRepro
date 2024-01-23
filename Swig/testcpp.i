%module(directors="1") TESTCPP

%{

//#include "QtCore/QObject.h"
#include "Base.h"
#include "Derived.h"

%}

//%include "std_string.i"

class QObject
{
public:
  QString objectName() const;
  void setObjectName(const QString &name);
};

/*
class QString 
{
public:
    static QString fromStdString(const std::string &s);
    std::string toStdString() const;
    
    int size() const;
    int count() const;
    int length() const;
    bool isEmpty() const;
};
*/

%include "std_shared_ptr.i"
%shared_ptr(QObject);
%shared_ptr(TestCpp::Base);
%shared_ptr(TestCpp::Derived);

//#undef QT_MODULE
//%include "../src/corelib/kernel/qobject.h"
//%include "QtCore/QObject.h"
%include "Base.h"
%include "Derived.h"

