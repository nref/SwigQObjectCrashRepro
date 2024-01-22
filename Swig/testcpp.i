%module(directors="1") TESTCPP

%{

#include "Base.h"
#include "Derived.h"
#include "Other.h"

%}

%include "std_string.i"
%include "std_shared_ptr.i"
%shared_ptr(TestCpp::Base);
%shared_ptr(TestCpp::Derived);
%shared_ptr(TestCpp::Other);
%include "Other.h"
%include "Base.h"
%include "Derived.h"

