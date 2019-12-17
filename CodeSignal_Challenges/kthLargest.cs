int kthLargestElement(int[] nums, int k) {
        
    Array.Sort(nums);
    Array.Reverse(nums);
    
    return nums[k-1];
    
    
}
