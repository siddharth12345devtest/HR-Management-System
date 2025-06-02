export interface UserAttendance {
  attendanceId: number;
  scUserId: number;
  loginTime?: string;
  logoutTime?: string;
  durationMinutes?: number;
  attLocLat?: number;
  attLocLon?: number;
  attLocName?: string;
  attLocAddress?: string;
  attLocAccuracy?: number;
  updateHash?: string;
  scCompanyId: number;
}
