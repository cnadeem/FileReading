﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFile
{
    public interface IFileColumnDelimiter
    {
        List<FileColumns> GetFileColumnLength();
    }
}
