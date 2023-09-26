using System;

class Solution {
    public int solution(string E, string L) {
        // Parse entry and exit times
        string[] entryTimeParts = E.Split(':');
        string[] exitTimeParts = L.Split(':');
        
        int entryHours = int.Parse(entryTimeParts[0]);
        int entryMinutes = int.Parse(entryTimeParts[1]);
        
        int exitHours = int.Parse(exitTimeParts[0]);
        int exitMinutes = int.Parse(exitTimeParts[1]);
        
        // Calculate total time parked in minutes
        int totalMinutes = (exitHours - entryHours) * 60 + (exitMinutes - entryMinutes);
        
        // Calculate cost based on billing rules
        int cost = 2; // Entrance fee
        
        if (totalMinutes <= 60) {
            cost += 3; // First hour
        } else {
            cost += 3; // First hour
            totalMinutes -= 60;
            cost += (totalMinutes / 60) * 4; // Additional full hours
            if (totalMinutes % 60 != 0) {
                cost += 4; // Partial hour
            }
        }
        
        return cost;
    }
}