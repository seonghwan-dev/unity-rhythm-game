// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Leaderboards
{
	/// <summary>
	/// Input parameters for the <see cref="LeaderboardsInterface.CopyLeaderboardRecordByUserId" /> function.
	/// </summary>
	public class CopyLeaderboardRecordByUserIdOptions
	{
		/// <summary>
		/// Leaderboard data will be copied from the cache if it relates to the user matching this Product User ID
		/// </summary>
		public ProductUserId UserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyLeaderboardRecordByUserIdOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_UserId;

		public ProductUserId UserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_UserId, value);
			}
		}

		public void Set(CopyLeaderboardRecordByUserIdOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LeaderboardsInterface.CopyleaderboardrecordbyuseridApiLatest;
				UserId = other.UserId;
			}
		}

		public void Set(object other)
		{
			Set(other as CopyLeaderboardRecordByUserIdOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_UserId);
		}
	}
}