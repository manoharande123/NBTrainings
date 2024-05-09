Create view  [bireports].[Test_vw_all_appt ]
as
(	SELECT DISTINCT mp.Insurancecarriersid ,mcd.memberchartdataid, mc.MemberChartID, mp.NHMemberID, mp.MemberProfileID
		,ma.MemberAppointmentId
		,at.AppointmentTypeId, AppointmentTypeName, ma.AppointmentStatus, ma.isactive IsActive, 
		CAST(ma.createdate AT TIME ZONE 'UTC'   AT TIME ZONE 'Eastern Standard Time' AS DATE) CreateDate,
		CAST(ma.StartDate AS DATE) AppointmentDate,
		JSON_VALUE(mcd.processData, '$.providerId') ProviderID , 
		JSON_VALUE(mcd.processData, '$.locationId')  LocationID , 
		JSON_VALUE(mcd.processData, '$.HCPUserProfileId') HCPUserProfileID,
		JSON_VALUE(mcd.processData, '$.InsuranceCarrierId') InsuranceCarrierId,
		JSON_VALUE(mcd.processData, '$.PlanId') PlanId,
		ma.CreateUser, ma.ModifyUser
		FROM [provider].[MemberAppointments] ma WITH (NOLOCK)
		LEFT OUTER JOIN [provider].[AppointmentTypes] at WITH (NOLOCK) ON (at.AppointmentTypeID = ma.AppointmentTypeID)
		LEFT OUTER JOIN [provider].[MemberChartData] mcd WITH (NOLOCK) ON (ma.MemberChartDataID = mcd.MemberChartDataID)
		LEFT OUTER JOIN [provider].[MemberCharts] mc WITH (NOLOCK) ON (mc.MemberChartID = mcd.MemberChartID)
		LEFT OUTER JOIN provider.MemberProfiles mp WITH (NOLOCK) ON (mp.memberprofileid = mc.memberprofileid)
		WHERE 1 = 1
		AND ma.isactive = 1

		AND at.AppointmentTypeName IN ('Testing')
		AND ma.AppointmentStatus NOT IN ('Cancel') 
		--AND CAST(JSON_VALUE(mcd.processData, '$.InsuranceCarrierId') AS INT) = @CarrierID		
		AND CAST(ma.createdate AT TIME ZONE 'UTC'  AT TIME ZONE 'Eastern Standard Time' AS DATE) > cast('20191231' as date)
		--AND CAST(ma.createdate AT TIME ZONE 'UTC'  AT TIME ZONE 'Eastern Standard Time' AS DATE) BETWEEN @StartDate AND @EndDate		
		AND ma.createuser NOT IN ('RMaram','testsatish','NHAdmin','testramu','Sareddy  Raj','sleathem','LBrown','rsareddy','sraghavendran','testmegha','testbhanu') 
	)


	--select top 10 * from provider.MemberProfiles