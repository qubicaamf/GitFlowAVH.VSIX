using System;
using GitFlowAVH.UI;
using Microsoft.TeamFoundation.Controls;
using GitFlowAVH.TeamExplorer;

namespace GitFlowAVH
{
    [TeamExplorerSection(GuidList.GitFlowInstallSection, GuidList.GitFlowPage, 100)]
    public class GitFlowInstallSection : TeamExplorerBaseSection, IGitFlowSection
    {
        public GitFlowInstallSection()
        {
            try
            {
                Title = "GitFlow AVH";
                SectionContent = new InstallGitFlowUI(this);

                UpdateVisibleState();

            }
            catch (Exception e)
            {
                HandleException(e);
            }
        }

		private void HandleException(Exception ex)
		{
			Logger.Exception(ex);
			ShowNotification(ex.Message, NotificationType.Error);
		}

        public void UpdateVisibleState()
        {
            IsVisible = !GitFlowPage.GitFlowIsInstalled || GitFlowPage.ActiveRepo == null;
        }
    }
}