using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidParenthese {

    public class Solution {
        public bool IsValid(string s) {
            var result = s.ToCharArray().ToList();
            bool value = true;

            for (int i = 0; i < result.Count; i++) {

                if (result[i].ToString().Equals("(")) {

                    if (result[i + 1].ToString().Equals(")")) {
                        value = true;
                    } else {
                        var count = result.Count;

                        if (count >= 3) {

                            var index = result[i + 1];

                            if (result[i + 2].ToString().Equals(")")) {
                                value = false;
                            } else if ((index.ToString().Equals("{") && result[i + 2].ToString().Equals("}"))
                                || (index.ToString().Equals("[") && result[i + 2].ToString().Equals("]"))) {

                                if (result[i + 3].ToString().Equals(")")) {
                                    value = true;
                                } else {
                                    var ind = result[i + 2];

                                    if ((ind.ToString().Equals("{") && result[i + 3].ToString().Equals("}"))
                                        || (ind.ToString().Equals("[") && result[i + 3].ToString().Equals("]"))) {

                                        if ((index.ToString().Equals("{") && result[i + 4].ToString().Equals("}"))
                                            || (index.ToString().Equals("[") && result[i + 4].ToString().Equals("]"))) {
                                            if (result[i + 5].ToString().Equals(")")) {
                                                value = true;
                                            } else {
                                                value = false;
                                            }
                                        } else {
                                            value = false;
                                        }
                                    } else {
                                        value = false;
                                    }
                                }
                            }

                        } else {
                            value = false;
                        }


                    }

                } else if (result[i].ToString().Equals("{")) {

                    if (result[i + 1].ToString().Equals("}")) {
                        value = true;
                    } else {
                        var count = result.Count;

                        if (count >= 3) {

                            var index = result[i + 1];

                            if (result[i + 2].ToString().Equals("}")) {
                                value = false;
                            } else if ((index.ToString().Equals("(") && result[i + 2].ToString().Equals(")"))
                                || (index.ToString().Equals("[") && result[i + 2].ToString().Equals("]"))) {

                                if (result[i + 3].ToString().Equals("}")) {
                                    value = true;
                                } else {
                                    var ind = result[i + 2];

                                    if ((ind.ToString().Equals("(") && result[i + 3].ToString().Equals(")"))
                                        || (ind.ToString().Equals("[") && result[i + 3].ToString().Equals("]"))) {

                                        if ((index.ToString().Equals("(") && result[i + 4].ToString().Equals(")"))
                                            || (index.ToString().Equals("[") && result[i + 4].ToString().Equals("]"))) {
                                            if (result[i + 5].ToString().Equals("}")) {
                                                value = true;
                                            } else {
                                                value = false;
                                            }
                                        } else {
                                            value = false;
                                        }
                                    } else {
                                        value = false;
                                    }
                                }
                            }

                        } else {
                            value = false;
                        }


                    }

                } else if (result[i].ToString().Equals("[")) {

                    if (result[i + 1].ToString().Equals("]")) {
                        value = true;
                    } else {
                        var count = result.Count;

                        if (count >= 3) {

                            var index = result[i + 1];

                            if (result[i + 2].ToString().Equals("]")) {
                                value = false;
                            } else if ((index.ToString().Equals("(") && result[i + 2].ToString().Equals(")"))
                                || (index.ToString().Equals("{") && result[i + 2].ToString().Equals("}"))) {

                                if (result[i + 3].ToString().Equals("]")) {
                                    value = true;
                                } else {
                                    var ind = result[i + 2];

                                    if ((ind.ToString().Equals("(") && result[i + 3].ToString().Equals(")"))
                                        || (ind.ToString().Equals("{") && result[i + 3].ToString().Equals("}"))) {

                                        if ((index.ToString().Equals("(") && result[i + 4].ToString().Equals(")"))
                                            || (index.ToString().Equals("{") && result[i + 4].ToString().Equals("}"))) {
                                            if (result[i + 5].ToString().Equals("]")) {
                                                value = true;
                                            } else {
                                                value = false;
                                            }
                                        } else {
                                            value = false;
                                        }
                                    } else {
                                        value = false;
                                    }
                                }
                            }

                        } else {
                            value = false;
                        }


                    }

                } else {

                }
            }

            return value;
        }
    }

    class ValidParentheses {
        public static void Main(string[] args) {
            var solution = new Solution();

            if (solution.IsValid(Console.ReadLine())) {
                Console.WriteLine("valid");
            } else {
                Console.WriteLine("invalid");
            }
        }
    }
}
