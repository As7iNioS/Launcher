using System;

namespace WowSuite.Launcher.Logic.Updating
{
    /// <summary>
    /// ��������� ������� ��������� ��������� ���������� ������-���� ��������.
    /// </summary>
    public class ProgressEventArgs : EventArgs
    {
        public ProgressEventArgs(int progress)
        {
            Progress = progress;
        }

        /// <summary>
        /// �������� ���������� �����-���� ��������
        /// </summary>
        public int Progress { get; protected set; }
    }
}