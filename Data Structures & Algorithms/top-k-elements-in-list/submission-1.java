class Solution {
    public int[] topKFrequent(int[] nums, int k) {

        // Hashmap to store the frequency of each number (k=number, v=frequency)
        HashMap<Integer, Integer> uniqueNumCount = new HashMap<>();

        // List of [frequence, number] pairs
        List<int[]> frequencyNumberPairs = new ArrayList<>();

        // Return Array of k most common numbers
        int[] mode = new int[k];

        // Fill the Hashmap with counts
        for (int num : nums) {
            if (!uniqueNumCount.containsKey(num)) {
                uniqueNumCount.put(num, 1);
            } else {
                int incrementedCount = uniqueNumCount.get(num) + 1;
                uniqueNumCount.replace(num, incrementedCount);
            }
        }

        for (Map.Entry<Integer, Integer> entry : uniqueNumCount.entrySet()) {
            frequencyNumberPairs.add(new int[] {entry.getValue(), entry.getKey()});
        }

        frequencyNumberPairs.sort((value, key) -> key[0] - value[0]);


        // Add values to the array by searching largest frequencies in list within map
        for (int i = 0; i < k; i++) {
            mode[i] = frequencyNumberPairs.get(i)[1];
        }


        return mode;
        
    }
}
