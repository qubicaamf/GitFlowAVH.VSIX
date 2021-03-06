﻿using GitFlowAVH;
using Microsoft.VisualStudio.Shell.Interop;

namespace GitFlowAVH
{
    public class VsGitFlowWrapper : GitFlowWrapper
    {
        public VsGitFlowWrapper(string repoPath,IVsOutputWindowPane outputWindow)
            : base(repoPath)
        {
            CommandOutputDataReceived += (o, args) => outputWindow.OutputStringThreadSafe(args.Output);
            CommandErrorDataReceived += (o, args) => outputWindow.OutputStringThreadSafe(args.Output);
        }

    }
}