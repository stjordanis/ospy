//
// Copyright (c) 2007 Ole Andr� Vadla Ravn�s <oleavr@gmail.com>
//
// This library is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

#pragma once

#ifndef INTERCEPTPP_API
#  ifdef INTERCEPTPP_EXPORTS
#    define INTERCEPTPP_API __declspec(dllexport)
#  else
#    define INTERCEPTPP_API __declspec(dllimport)
#  endif
#endif

#include "STL.h"
#include <windows.h>
